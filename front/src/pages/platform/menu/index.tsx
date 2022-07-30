import { SexMap, typeMap } from '@/const/map';
import ActionButtonContainer from '@/pages/components/ActionButtonContainer';
import { getApplicationTree } from '@/services/z-admin/applicationService';
import { deleteMenu, menuListPage } from '@/services/z-admin/menuService';
import { PlusOutlined } from '@ant-design/icons';
import {
  ActionType,
  GridContent,
  ProColumns,
  ProFormInstance,
  ProTable,
} from '@ant-design/pro-components';
import { Button, Card, Col, Row } from 'antd';
import Tree, { DataNode } from 'antd/lib/tree';
import { cloneDeep, merge } from 'lodash';
import { useRef, useState } from 'react';
import { useRequest } from 'umi';
import MenuEditModal, { EditModalProps } from './components/editModal';

const MenuList: React.FC = () => {
  const defalutEditPropsValue = {
    title: '编辑',
    values: {},
    visiable: true,
  };

  const [editModalProps, setEditModalProps] = useState<EditModalProps>({
    title: '编辑',
    values: {},
    visiable: false,
  });

  const [paramTable, setParamTable] = useState<any>({
    application: 'NONE',
  });

  const pageEvent = {
    editMenu: (entity: any) => {
      setEditModalProps((prevState) =>
        merge(defalutEditPropsValue, {
          values: entity,
          visiable: true,
          action: 'edit',
          extras: {
            ...paramTable,
          },
        } as EditModalProps),
      );
    },
    addMenu: () => {
      setEditModalProps((prevState) =>
        merge(defalutEditPropsValue, {
          title: '新增',
          visiable: true,
          action: 'add',
          values: {
            id: 0,
            pid: 0,
            name: '',
            code: '',
            icon: '',
            router: '',
            component: '',
            permission: '',
            application: '',
            visible: 'Y',
            link: '',
            redirect: '',
            weight: 1,
            sort: 0,
            remark: '',
            type: 0,
            openType: 0,
          },
          extras: {
            ...paramTable,
          },
        } as EditModalProps),
      );
    },

    deleteMenu: async (entity: any) => {
      await deleteMenu({ id: entity.id });
      actionRef.current?.reload();
    },
  };

  const actionRef = useRef<ActionType>();
  const tableRef = useRef<ProFormInstance>();

  const columns: ProColumns[] = [
    {
      title: '序号',
      dataIndex: 'id',
      valueType: 'textarea',
      hideInTable: true,
      search: false,
    },
    {
      title: '菜单名称',
      dataIndex: 'name',
      valueType: 'textarea',
      search: false,
    },
    {
      title: '菜单类型',
      dataIndex: 'type',
      valueType: 'select',
      valueEnum: typeMap,
      search: false,
    },
    {
      title: '图标',
      dataIndex: 'icon',
      valueType: 'textarea',
      search: false,
    },
    {
      title: '组件',
      dataIndex: 'component',
      valueType: 'textarea',
      search: false,
    },
    {
      title: '路由地址',
      dataIndex: 'router',
      valueType: 'textarea',
      search: false,
    },
    {
      title: '排序',
      dataIndex: 'sort',
      valueType: 'textarea',
      search: false,
    },
    {
      title: '操作',
      dataIndex: 'option',
      valueType: 'option',
      render: (dom, entity) => {
        return (
          <ActionButtonContainer
            scheme={[
              {
                name: '编辑',
                type: 'button',
                onClick: () => {
                  pageEvent.editMenu(entity);
                },
              },
              {
                name: '操作',
                type: 'dropdown',
                children: [
                  {
                    name: '删除',
                    type: 'menu',
                    onClick: () => {
                      pageEvent.deleteMenu(entity);
                    },
                  },
                ],
              },
            ]}
          />
        );
      },
    },
  ];
  // [
  //   // eslint-disable-next-line react/jsx-key
  //   ,
  // ],
  const { data: ApplicationTree, loading: ApplicationLoading } = useRequest(
    () => {
      return getApplicationTree();
    },
    {
      throwOnError: true,
      formatResult: (source) => {
        const target = cloneDeep(source) as myAPI.ApplicationTreeResponse;

        return target.data.map((src) => {
          return {
            title: src.name,
            key: src.code,
            children: [],
          };
        });
      },
    },
  );

  return (
    <GridContent>
      <Row gutter={24}>
        <Col lg={7} md={24}>
          <Card bordered={false} style={{ marginBottom: 24 }} loading={ApplicationLoading}>
            {!ApplicationLoading == true ? (
              <Tree
                defaultExpandAll
                treeData={ApplicationTree as any}
                onSelect={(keys, info) => {
                  // console.log("Keys:"+JSON.stringify(keys)+"info:"+JSON.stringify(info))
                  // setParamTable({ "sysEmpParam.orgId": keys[0] }
                  // if (tableRef.current) {
                  //     tableRef.current.submit()
                  //     // actionRef.current?.set
                  // }
                  setParamTable({ application: keys[0] });
                  if (tableRef.current) {
                    tableRef.current.submit();
                  }
                }}
              />
            ) : (
              <div />
            )}
          </Card>
        </Col>
        <Col lg={17} md={24}>
          <Card bordered={false} style={{ marginBottom: 24 }} loading={false}>
            <ProTable
              actionRef={actionRef}
              formRef={tableRef}
              columns={columns}
              params={paramTable}
              toolBarRender={() => [
                <Button
                  key="button"
                  icon={<PlusOutlined />}
                  type="primary"
                  onClick={() => {
                    pageEvent.addMenu();
                  }}
                >
                  新增菜单
                </Button>,
              ]}
              request={menuListPage}
            />
          </Card>
        </Col>
      </Row>

      <MenuEditModal
        {...editModalProps}
        onFinish={() => {
          actionRef.current?.reload();
          setEditModalProps(
            merge(defalutEditPropsValue, { visiable: false, action: '' } as EditModalProps),
          );
        }}
        onCancel={(b) => {
          if (!b) {
            setEditModalProps(
              merge(defalutEditPropsValue, { visiable: false, action: '' } as EditModalProps),
            );
          }
        }}
      />
    </GridContent>
  );
};

export default MenuList;

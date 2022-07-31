import { commonMap } from '@/const/map';
import { systemPage } from '@/services/z-admin/configService';
import { getDictDataList } from '@/services/z-admin/dictDataService';
import { PlusOutlined } from '@ant-design/icons';
import {
  ActionType,
  GridContent,
  ProColumns,
  ProFormInstance,
  ProTable,
  srRSIntl,
} from '@ant-design/pro-components';
import { Button, Card, Col, Row } from 'antd';
import { merge } from 'lodash';
import { useRef, useState } from 'react';
import ActionButtonContainer from '../../components/ActionButtonContainer';
import ConfigModal, { EditModalProps } from './components/editModal';

const ConfigList: React.FC = () => {
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

  const pageEvent = {
    edit: (entity: any) => {
      setEditModalProps((prevState) =>
        merge(defalutEditPropsValue, {
          values: entity,
          visiable: true,
          action: 'edit',
        } as EditModalProps),
      );
    },
    add: () => {
      setEditModalProps((prevState) =>
        merge(defalutEditPropsValue, {
          title: '新增',
          visiable: true,
          action: 'add',
          values: {
            name: '',
            code: '',
            sysFlag: 'Y',
            groupCode: '',
            value: '',
            remark: '',
          },
        } as EditModalProps),
      );
    },
    // deleteMenu: async (entity: any) => {
    //   await deleteMenu({ id: entity.id });
    //   actionRef.current?.reload();
    // },
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
      title: '参数名称',
      dataIndex: 'name',
      valueType: 'textarea',
    },
    {
      title: '唯一编码',
      dataIndex: 'name',
      valueType: 'textarea',
    },
    {
      title: '参数值',
      dataIndex: 'value',
      valueType: 'textarea',
      search: false,
    },
    {
      title: '所属分类',
      key: '',
      dataIndex: 'groupCode',
      valueType: 'select',
      request: async () => {
        const data = [] as any;
        const ret = await getDictDataList({ typeId: 142307070906485 });
        ret.data.forEach((src) => {
          data.push({
            label: src.value,
            value: src.code,
          });
        });
        return Promise.resolve(data);
      },
    },

    {
      title: '状态',
      dataIndex: 'status',
      valueType: 'select',
      valueEnum: commonMap,
      hideInSearch: true,
    },
    {
      title: '备注',
      dataIndex: 'remark',
      valueType: 'textarea',
    },
    {
      title: '操作',
      dataIndex: 'option',
      valueType: 'option',
      render: (dom, entity) => (
        <ActionButtonContainer
          scheme={[
            {
              name: '编辑',
              type: 'button',
              onClick: () => {
                pageEvent.edit(entity);
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
                    //   pageEvent.deleteApplication(entity);
                  },
                },
              ],
            },
          ]}
        />
      ),
    },
  ];

  return (
    <GridContent>
      <Row gutter={24}>
        <Col lg={24} md={24}>
          <Card bordered={false} style={{ marginBottom: 24 }} loading={false}>
            <ProTable<any>
              headerTitle="查询表格"
              toolBarRender={() => [
                <Button
                  key="button"
                  icon={<PlusOutlined />}
                  type="primary"
                  onClick={() => {
                    pageEvent.add();
                  }}
                >
                  新增应用
                </Button>,
              ]}
              actionRef={actionRef}
              formRef={tableRef}
              columns={columns}
              request={async (
                params: {
                  // query
                  /** 当前的页码 */
                  current?: number;
                  /** 页面的容量 */
                  pageSize?: number;
                },
                sort: any,
                filter: any,
              ) => {
                const ret = await systemPage(params, sort, filter);

                return Promise.resolve({
                  data: ret.data.rows,
                  success: ret.success,
                  total: ret.data.totalRows,
                }) as any;
              }}
            />
          </Card>
        </Col>
      </Row>

      <ConfigModal
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

export default ConfigList;

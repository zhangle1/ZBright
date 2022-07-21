import { SexMap, typeMap } from '@/const/map';
import { getApplicationTree } from '@/services/z-admin/applicationService';
import { menuListPage } from '@/services/z-admin/menu';
import {
  ActionType,
  GridContent,
  ProColumns,
  ProFormInstance,
  ProTable,
} from '@ant-design/pro-components';
import { Card, Col, Row } from 'antd';
import Tree, { DataNode } from 'antd/lib/tree';
import { cloneDeep } from 'lodash';
import { useRef, useState } from 'react';
import { useRequest } from 'umi';

const MenuList: React.FC = () => {
  const defalutEditPropsValue = {
    title: '编辑',
    values: {},
    visiable: true,
  };

  const pageEvent = {};

  const actionRef = useRef<ActionType>();
  const tableRef = useRef<ProFormInstance>();

  const [paramTable, setParamTable] = useState<any>({
    application: 'NONE',
  });

  const columns: ProColumns[] = [
    {
      title: '序号',
      dataIndex: 'id',
      valueType: 'textarea',
      hideInTable: true,
    },
    {
      title: '菜单名称',
      dataIndex: 'name',
      valueType: 'textarea',
    },
    {
      title: '菜单类型',
      dataIndex: 'type',
      valueType: 'select',
      valueEnum: typeMap,
    },
    {
      title: '图标',
      dataIndex: 'icon',
      valueType: 'textarea',
    },
    {
      title: '组件',
      dataIndex: 'component',
      valueType: 'textarea',
    },
  ];

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
              request={menuListPage}
            ></ProTable>
          </Card>
        </Col>
      </Row>
    </GridContent>
  );
};

export default MenuList;

import { commonMap, SexMap } from '@/const/map';
import ActionButtonContainer from '@/pages/components/ActionButtonContainer';
import { getOrgTree } from '@/services/z-admin/org';
import { PlusOutlined } from '@ant-design/icons';
import { ProFormInstance } from '@ant-design/pro-form';
import { GridContent } from '@ant-design/pro-layout';
import ProTable, { ActionType, ProColumns } from '@ant-design/pro-table';
import { Button, Card, Tree } from 'antd';
import { Col, Row } from 'antd/lib/grid';
import { cloneDeep, merge } from 'lodash';
import React, { useEffect, useRef, useState } from 'react';
import { useRequest } from 'umi';
import PermissionEditModal, { EditModalProps } from './components/editModal';
import { userPage } from './service';

const UserPermissionList: React.FC = () => {

    const defalutEditPropsValue = {
        title: '编辑', values: {
            sysEmpInfo: {
                positions: [],
                extOrgPos: [],
            }
        }, visiable: true
    }
    const [editModalProps, setEditModalProps] = useState<EditModalProps>({
        title: '编辑', values: {
            sysEmpInfo: {
                positions: [],
                extOrgPos: [],
            }
        }, visiable: false
    })

    const pageEvent = {
        addUser: () => {
            setEditModalProps((prevState) => (merge(defalutEditPropsValue, { title: '新增', visiable: true, action: 'add' } as EditModalProps)))
        },
        editUser: (entity: any) => {

            setEditModalProps((prevState) => (merge(defalutEditPropsValue, { values: entity, visiable: true, action: 'edit' } as EditModalProps)))
        }
    }



    const { data: OrgTree, loading: OrgTreeLoading } = useRequest(() => {
        return getOrgTree()
    }, {
        throwOnError: true, formatResult: (source) => {
            const target = cloneDeep(source) as myAPI.OrgTreeFormatResponse
            recursionChild(target.data)
            return target;
        }
    })
    useEffect(() => {
    }, [OrgTree])

    const columns: ProColumns[] = [
        {
            title: '序号',
            dataIndex: 'id',
            valueType: 'textarea',
            hideInTable: true
        },
        {
            title: '账号',
            dataIndex: 'account',
            valueType: 'textarea',

        },
        {
            title: '姓名',
            dataIndex: 'nickName',
            valueType: 'textarea',
        },
        {
            title: '性别',
            dataIndex: 'sex',
            valueType: 'select',
            valueEnum: SexMap
        },
        {
            title: '手机',
            dataIndex: 'phone',
            valueType: 'textarea',
        },
        {
            title: '状态',
            dataIndex: 'status',
            valueType: 'select',
            valueEnum: commonMap
        },

        // {
        //     title: '角色',
        //     dataIndex: 'roleGroupName',
        //     valueType: 'select',
        //     filters: true,
        //     onFilter: true,
        //     valueEnum: {
        //         all: { text: '全部', status: 'Default' },
        //         running: { text: '管理员', status: 'Processing' },
        //         online: { text: '普通用户', status: 'Success' },
        //         error: { text: '异常', status: 'Error' },
        //     },
        //     fieldProps: {
        //         mode: 'multiple'
        //     }
        // },

        {
            title: '操作',
            dataIndex: 'option',
            valueType: 'option',
            render: (dom, entity) => [
                // eslint-disable-next-line react/jsx-key
                <ActionButtonContainer scheme
                    ={[{
                        name: '编辑',
                        type: 'button',
                        onClick: () => {
                            pageEvent.editUser(entity)
                        },
                    },{
                        name: '操作',
                        type: 'dropdown',
                        children:[
                            {
                                name:'删除',
                                type:'menu',
                                onClick:()=>{

                                },
                        }
                        ] 
                    }]} />

            ],
        },
    ]
    const actionRef = useRef<ActionType>();
    const tableRef = useRef<ProFormInstance>();

    const [paramTable, setParamTable] = useState<any>({});

    function recursionChild(item: myAPI.OrgTreeView[]) {
        if (item.length > 0) {
            item.forEach((a, _) => {
                a.key = a.value.toString();
                recursionChild(a.children)
            })
        }
    }
    return (
        <GridContent>
            <Row gutter={24}>
                <Col lg={7} md={24}>
                    <Card bordered={false} style={{ marginBottom: 24 }} loading={OrgTreeLoading}>
                        {(!OrgTreeLoading) == true ? (<Tree
                            defaultExpandAll
                            treeData={OrgTree?.data as any}
                            onSelect={(keys, info) => {
                                // console.log("Keys:"+JSON.stringify(keys)+"info:"+JSON.stringify(info))
                                if (keys.length == 1) {
                                    setParamTable({ "sysEmpParam.orgId": keys[0] }
                                    )
                                    if (tableRef.current) {
                                        tableRef.current.submit()
                                        // actionRef.current?.set
                                    }
                                }


                            }}

                        />) : (<div />)}
                    </Card>
                </Col>
                <Col lg={17} md={24}>
                    <Card bordered={false} style={{ marginBottom: 24 }} loading={false}>
                        <ProTable<{
                            account: '',
                            sysEmpParam: {
                                orgId: ''
                            },
                        },
                            {
                                account: '',
                                sysEmpParam: {
                                    orgId: ''
                                },
                            }
                        >
                            headerTitle="查询表格"
                            toolBarRender={() => [
                                <Button key="button" icon={<PlusOutlined />} type="primary" onClick={() => {
                                    pageEvent.addUser()
                                }}>
                                    新增用户
                                </Button>,
                            ]}
                            actionRef={actionRef}
                            formRef={tableRef}
                            columns={columns}
                            params={paramTable}
                            beforeSearchSubmit={((param) => {
                                if (paramTable != undefined) {
                                    // param?.sysEmpParam?.orgId = paramTable
                                    return param
                                }

                                return param
                            })}
                            request={userPage}
                        />
                    </Card>
                </Col>
            </Row>
            <PermissionEditModal  {...editModalProps}
                onFinish={() => {
                    actionRef.current?.reload()
                    setEditModalProps(merge(defalutEditPropsValue, { visiable: false, action: '' } as EditModalProps))
                }}
                onCancel={(b) => {
                    if (!b) {
                        setEditModalProps(merge(defalutEditPropsValue, { visiable: false, action: '' } as EditModalProps))
                    }
                }
                }
            />,

        </GridContent>


        // <PageContainer>

        // </PageContainer>
    )
}

export default UserPermissionList;
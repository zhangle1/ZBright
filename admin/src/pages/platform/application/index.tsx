import { commonMap, DefaultMap, SexMap } from '@/const/map';
import { ApplicationEntity } from '@/model/application';
import ActionButtonContainer from '@/pages/components/ActionButtonContainer';
import { PlusOutlined } from '@ant-design/icons';
import { ProFormInstance } from '@ant-design/pro-form';
import { GridContent } from '@ant-design/pro-layout';
import ProTable, { ActionType, ProColumns } from '@ant-design/pro-table';
import { Button, Card, Tree } from 'antd';
import { Col, Row } from 'antd/lib/grid';
import { cloneDeep, merge } from 'lodash';
import React, { useEffect, useRef, useState } from 'react';
import ApplicationFieldModal from './components/fieldModal';
import { applicationPage } from './service';

export type FieldModalProps = {
    title?: string,
    values: Partial<ApplicationEntity>,
    visiable: boolean,
    onFinish?: Function,
    onCancel?: (visible: boolean) => void,
    action?: string,
}

const ApplicationList: React.FC = () => {

    const defalutFieldPropsValue = {
        title: '编辑',
        values: {},
        visiable: true
    }

    const [FieldModalProps, setFieldModalProps] = useState<FieldModalProps>(
        {
            title: '编辑',
            values: {},
            visiable: false,

        }
    )

    const pageEvent = {
        addApplication: () => {
            setFieldModalProps((prevState) => (merge(defalutFieldPropsValue, { title: '新增', visiable: true, action: 'add' } as FieldModalProps)))
        },
        editApplication: (entity: any) => {
            setFieldModalProps((prevState) => (merge(defalutFieldPropsValue, { title: '编辑',values:entity,   visiable: true, action: 'edit' } as FieldModalProps)))
        }
    }

    const columns: ProColumns[] = [
        {
            title: '序号',
            dataIndex: 'id',
            valueType: 'textarea',
            hideInTable: true,
            hideInSearch: true,

        },
        {
            title: '应用名称',
            dataIndex: 'name',
            valueType: 'textarea',
        },
        {
            title: '唯一编码',
            dataIndex: 'code',
            valueType: 'textarea',
        },
        {
            title: '是否默认',
            dataIndex: 'active',
            valueType: 'select',
            valueEnum: DefaultMap,
            hideInSearch: true,

        },
        {
            title: '状态',
            dataIndex: 'status',
            valueType: 'select',
            valueEnum: commonMap,
            hideInSearch: true,

        },
        {
            title: '排序',
            dataIndex: 'sort',
            valueType: 'textarea',
            hideInSearch: true,
        },
        {
            title: '操作',
            dataIndex: 'option',
            valueType: 'option',
            render: (dom, entity) =>
                <ActionButtonContainer scheme
                    ={[{
                        name: '编辑',
                        type: 'button',
                        onClick: () => {
                            pageEvent.editApplication(entity)
                        },
                    }, {
                        name: '操作',
                        type: 'dropdown',
                        children: [
                            {
                                name: '删除',
                                type: 'menu',
                                onClick: () => {

                                },
                            }
                        ]
                    }]} />
        }
    ]
    const actionRef = useRef<ActionType>();
    const tableRef = useRef<ProFormInstance>();

    const [paramTable, setParamTable] = useState<any>({});


    return (<GridContent>
        <Row gutter={24}>
            <Col lg={24} md={24}>
                <Card bordered={false} style={{ marginBottom: 24 }} loading={false} >
                    <ProTable<any>
                        headerTitle="查询表格"
                        toolBarRender={() => [
                            <Button key="button" icon={<PlusOutlined />} type="primary" onClick={() => {
                                pageEvent.addApplication()
                            }}>
                                新增应用
                            </Button>,
                        ]}
                        actionRef={actionRef}
                        formRef={tableRef}
                        columns={columns}
                        params={paramTable}
                        request={applicationPage}
                    />
                </Card>
            </Col>
        </Row>
        <ApplicationFieldModal {...FieldModalProps}
            onFinish={() => {
                actionRef.current?.reload()
                setFieldModalProps(merge(defalutFieldPropsValue, { visiable: false, action: '' } as FieldModalProps))
            }}
            onCancel={(b) => {
                if (!b) {
                    setFieldModalProps(merge(defalutFieldPropsValue, { visiable: false, action: '' } as FieldModalProps))
                }     
            }
            }

        />

    </GridContent>)
}


export default ApplicationList;
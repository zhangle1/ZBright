import { SexMap } from "@/const/map";
import { ExtOrgPos } from "@/model/emp";
import { Positions } from "@/model/posistion";
import { UserEntity } from "@/model/user";
import { convertOrgToTreeSelect, convertPositionToSelect } from "@/services/convert";
import { positionsList } from "@/services/position";
import { getOrgTree } from "@/services/z-admin/org";
import { PlusOutlined } from "@ant-design/icons";
import ProForm, { ModalForm, ProFormDatePicker, ProFormInstance, ProFormSelect, ProFormText, ProFormTreeSelect } from "@ant-design/pro-form";
import { EditableFormInstance, EditableProTable, ProColumns } from "@ant-design/pro-table";


import { Button, Divider } from "antd";
import { Label } from "bizcharts";
import { cloneDeep } from "lodash";
import { useEffect, useMemo, useRef, useState } from "react";
import { useRequest } from "umi";
import { userAdd, userEdit } from "../service";

export type EditModalProps = {
    title?: string,
    values: Partial<UserEntity>,
    visiable: boolean,
    onFinish?: Function,
    onCancel?: (visible: boolean) => void,
    action?: string,
}


const PermissionEditModal: React.FC<EditModalProps> = (props) => {

    const editFormRef = useRef<ProFormInstance>();

    const mergeProps = useMemo(() => {

        return { ...props }
    }, [props])
    // const mergeProps = props

    var index = 1;
    mergeProps.values.sysEmpInfo.extOrgPos.forEach((item, i) => {
        item.id = index
        index = index + 1
    })

    const editorFormRef = useRef<EditableFormInstance<ExtOrgPos>>();


    const [editableKeys, setEditableRowKeys] = useState<React.Key[]>(
        mergeProps.values.sysEmpInfo.extOrgPos.map((item) => item.id),
    );
    const [dataSource, setDataSource] = useState<ExtOrgPos[]>(mergeProps.values.sysEmpInfo?.extOrgPos || []);
    useEffect(() => {
        console.log("datasource 切换" + JSON.stringify(mergeProps.values.sysEmpInfo?.extOrgPos))
        editorFormRef.current?.resetFields()
        editFormRef.current?.resetFields()

        setEditableRowKeys(mergeProps.values.sysEmpInfo.extOrgPos.map((item) => item.id))
        setDataSource(mergeProps.values.sysEmpInfo?.extOrgPos || [])
    }, [
        mergeProps.values.sysEmpInfo
    ])

    const columns: ProColumns<ExtOrgPos>[] = [
        {
            title: '附属机构',
            key: 'orgId',
            dataIndex: 'orgId',
            valueType: 'treeSelect',
            request: async () => {
                return await convertOrgToTreeSelect();
            },
            fieldProps: {
                showArrow: false,
                filterTreeNode: true,
                showSearch: true,
                dropdownMatchSelectWidth: false,
                treeDefaultExpandAll: true,
            }
        },
        {
            title: '附属职位',
            key: 'posId',
            dataIndex: 'posId',
            valueType: 'select',
            request: async () => {
                return await convertPositionToSelect();
            }
        },

        {
            title: '操作',
            valueType: 'option',
            width: 250,
            render: () => {
                return null;
            },
        },
    ];


    const onFinish = async (value: any) => {
        if (mergeProps.action == 'edit') {
            value.sysEmpInfo.posIdList = value.positionsCode.map((src: number) => { return src })
            value.sysEmpInfo.extIds = dataSource
            value.sysEmpParam = value.sysEmpInfo
            await userEdit(value)
        } else {
            value.sysEmpInfo.posIdList = value.positionsCode.map((src: number) => { return src })
            value.sysEmpInfo.extIds = dataSource
            value.sysEmpParam = value.sysEmpInfo
            console.log("添加用户：" + JSON.stringify(value))
            await userAdd(value)
        }
        mergeProps.onFinish?.()
    }



    return (
        <ModalForm
            width="md"
            initialValues={{ ...mergeProps.values, ...{ positionsCode: mergeProps.values.sysEmpInfo?.positions.map(src => src.posId) } }}
            visible={mergeProps.visiable}
            title={mergeProps.title}
            formRef={editFormRef}

            onVisibleChange={mergeProps?.onCancel}
            onFinish={onFinish}

        >
            <Divider orientation="left">基本信息</Divider>
            <ProFormText
                width="md"
                name="id"
                label="账户"
                placeholder="请输入账户"
                hidden
            />

            <ProForm.Group>
                <ProFormText
                    width="md"
                    name="account"
                    label="账户"
                    tooltip="最长为 24 位"
                    placeholder="请输入账户"
                    rules={[{ required: true, message: '账户为必填' }]}
                />
                <ProFormText
                    width="md"
                    name="name"
                    label="姓名"
                    tooltip="最长为 24 位"
                    placeholder="请输入姓名"
                    rules={[{ required: true, message: '姓名为必填' }]}
                />
            </ProForm.Group>
            <ProForm.Group>
                <ProFormText
                    width="md"
                    name="nickName"
                    label="昵称"
                    placeholder="请输入昵称"
                />
                <ProFormDatePicker name="birthday" label="生日" />
            </ProForm.Group>
            {mergeProps.action=='add'?(
                <ProForm.Group>
                <ProFormText
                    width="md"
                    name="password"
                    label="密码"
                    tooltip="最长为 24 位"
                    placeholder="请输入密码"
                    rules={[{ required: true, message: '密码为必填' }]}
                />
                <ProFormText
                    width="md"
                    name="confirm"
                    label="确认密码"
                    tooltip="最长为 24 位"
                    placeholder="请输入确认密码"
                    rules={[{ required: true, message: '确认密码为必填' }]}
                />
            </ProForm.Group>

          ):(<></>)}
            <ProForm.Group>
                <ProFormSelect
                    name="sex"
                    width="md"
                    label="性别"
                    options={
                        [{ value: 1, label: '男' }
                            , { value: 2, label: '女' }
                            , { value: 3, label: '未知性别' }
                        ]
                    }
                    valueEnum={SexMap}
                    rules={[{ required: true, message: '性别为必填' }]}
                />
                <ProFormText
                    width="md"
                    name="email"
                    label="邮箱"
                    tooltip="最长为 24 位"
                    placeholder="请输入email"
                    rules={[{ required: true, message: '邮箱为必填' }]}
                />
            </ProForm.Group>

            <ProForm.Group>
                <ProFormText
                    width="md"
                    name="phone"
                    label="手机号"
                    tooltip="最长为 24 位"
                    placeholder="请输入手机号"
                    rules={[{ required: true, message: '手机号为必填' }]}
                />
                <ProFormText
                    width="md"
                    name="tel"
                    label="tel"
                    tooltip="最长为 24 位"
                    placeholder="请输入电话"
                    rules={[{ required: true, message: '电话为必填' }]}
                />
            </ProForm.Group>

            <Divider orientation="left">员工信息</Divider>

            <ProForm.Group>
                <ProFormTreeSelect

                    name={["sysEmpInfo", "orgId"]}
                    label="机构"
                    placeholder="请选择机构"
                    allowClear
                    width="md"


                    request={async () => {
                        return await convertOrgToTreeSelect();
                    }}
                    // tree-select args
                    fieldProps={{
                        // autoClearSearchValue: true,
                        treeDefaultExpandAll: true,

                    }}
                />

                <ProFormText
                    width="md"
                    name={["sysEmpInfo", "jobNum"]}
                    label="工号"
                    tooltip="最长为 24 位"
                    placeholder="请输入工号"
                    rules={[{ required: true, message: '工号为必填' }]}
                />
            </ProForm.Group>
            <ProFormSelect
                mode="multiple"
                name={['positionsCode']}
                label="职位信息"
                request={async () => {
                    return await convertPositionToSelect()
                }

                }
                placeholder="请选择职位信息"
                rules={[{ required: true, message: '请选择职位信息' }]}
            />
            <EditableProTable<ExtOrgPos>
                headerTitle="可编辑表格"
                columns={columns}
                editableFormRef={editorFormRef}

                rowKey="id"
                scroll={{
                    x: 960,
                }}
                value={dataSource}
                onChange={setDataSource}
                recordCreatorProps={{
                    newRecordType: 'dataSource',
                    record: () => ({
                        id: Date.now(),
                    }),
                }}

                editable={{
                    type: 'multiple',
                    editableKeys,
                    actionRender: (row, config, defaultDoms) => {
                        return [defaultDoms.delete];
                    },
                    onValuesChange: (record, recordList) => {

                        console.log("recordList:" + JSON.stringify(recordList))
                        setDataSource(recordList);
                    },
                    onChange: setEditableRowKeys,
                }}
            />

        </ModalForm>
    );
}

export default PermissionEditModal;



PermissionEditModal.defaultProps = {
    title: "编辑",

}


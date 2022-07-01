import { ApplicationEntity } from "@/model/application"
import type { ProFormInstance} from "@ant-design/pro-form";
import ProForm, { ModalForm, ProFormDigit, ProFormText } from "@ant-design/pro-form";
import { Row } from "antd";
import { useEffect, useMemo, useRef } from "react";
import { applicationAdd, applicationEdit } from "../service";

export type FieldModalProps = {
    title?: string,
    values: Partial<ApplicationEntity>
    visiable: boolean,
    onFinish?: Function,
    onCancel?: (visible: boolean) => void,
    action?: string,
}

const ApplicationFieldModal: React.FC<FieldModalProps> = (props) => {

    const fieldFormRef = useRef<ProFormInstance>();

    const mergeProps = useMemo(() => {

        return { ...props }
    }, [props])

    useEffect(()=>{
        fieldFormRef.current?.resetFields()
    },[props])

    const onFinish = async (value: any) => {
        if (mergeProps.action == 'edit') {
            await applicationEdit(value)
        }else{
            await applicationAdd(value)
        }
        mergeProps.onFinish?.()
    }

    return (
        <ModalForm
            width="md"
            initialValues={{ ...mergeProps.values }}
            visible={mergeProps.visiable}
            title={mergeProps.title}
            formRef={fieldFormRef}
            onVisibleChange={mergeProps?.onCancel}
            onFinish={onFinish}
        >
            <ProFormText
                width="md"
                name="id"
                label="序号"
                placeholder="请输入账户"
                hidden
            />
            <ProFormText
                width="md"
                name="active"
                label="是否默认"
                hidden
            />
            <ProForm.Group>
                <ProFormText
                    width="md"
                    name="name"
                    label="应用名称"
                    tooltip="最长为 24 位"
                    placeholder="请输入应用名称"
                    rules={[{ required: true, message: '应用名称为必填' }]}
                />
            </ProForm.Group>
            <ProForm.Group>
                <ProFormText
                    width="md"
                    name="code"
                    label="唯一编码"
                    tooltip="最长为 24 位"
                    placeholder="请输入唯一编码"
                    rules={[{ required: true, message: '唯一编码为必填' }]}
                />
            </ProForm.Group>
                <ProFormDigit
                    name="sort"
                    label="排序"
                    tooltip="最长为 24 位"
                    placeholder="请输入默认排序"
                />
             
        </ModalForm>
    )

}

export default ApplicationFieldModal;

ApplicationFieldModal.defaultProps = {
    title: "编辑"
}
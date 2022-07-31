import type { ConfigEntity } from '@/model/config';
import { addConfig, editConfig } from '@/services/z-admin/configService';
import { getDictDataList } from '@/services/z-admin/dictDataService';
import type { ProFormInstance } from '@ant-design/pro-components';
import {
  ModalForm,
  ProFormSelect,
  ProFormSwitch,
  ProFormText,
  ProFormTextArea,
} from '@ant-design/pro-components';
import { Divider } from 'antd';
import { useRef } from 'react';

export type EditModalProps = {
  title?: string;
  values: Partial<ConfigEntity>;
  visiable: boolean;
  onFinish?: Function;
  onCancel?: (visible: boolean) => void;
  action?: string;
};

const ConfigModal: React.FC<EditModalProps> = (props) => {
  const editFormRef = useRef<ProFormInstance>();

  if (props.action == 'add') {
    editFormRef.current?.setFieldsValue(props.values);
  } else if (props.action == 'edit') {
    editFormRef.current?.setFieldsValue(props.values);
  }

  const onFinish = async (value: any) => {
    if (props.action == 'edit') {
      await editConfig(value);
    } else {
      await addConfig(value);
    }
    props.onFinish?.();
  };

  const onValuesChange = (changeValues: any) => {
    // const mergeData = handleFormValueTransform(
    //   merge(props, { values: { ...changeValues } }),
    //   changeValues,
    // );
    // console.log('改变了：' + mergeData.values);
    // editFormRef.current?.setFieldsValue(mergeData.values);
  };

  return (
    <ModalForm
      initialValues={props.values}
      visible={props.visiable}
      title={props.title}
      formRef={editFormRef}
      onVisibleChange={props?.onCancel}
      onFinish={onFinish}
      onValuesChange={onValuesChange}
    >
      <Divider orientation="left">配置信息</Divider>
      <ProFormText width="md" name="id" label="账户" placeholder="请输入账户" hidden />
      <ProFormText width="md" name="name" label="参数名称" placeholder="请输入参数名称" />
      <ProFormText width="md" name="code" label="唯一编码" placeholder="请输入唯一编码" />
      <ProFormSwitch width="md" label="系统参数" name="sysFlag" />

      <ProFormSelect
        width="md"
        name="groupCode"
        label="所属应用"
        placeholder="请选择所属应用"
        request={async () => {
          const data = [] as any;
          const ret = await getDictDataList({ typeId: 142307070906485 });
          ret.data.forEach((src) => {
            data.push({
              label: src.value,
              value: src.code,
            });
          });
          return Promise.resolve(data);
        }}
      />

      <ProFormText width="md" name="value" label="参数值" placeholder="请输入参数值" />

      <ProFormTextArea width="md" name="remark" label="备注" placeholder="请输入备注" />
    </ModalForm>
  );
};

export default ConfigModal;

ConfigModal.defaultProps = {
  title: '编辑',
};

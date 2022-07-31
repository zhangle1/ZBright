import { convertMapToArray, openTypeArray, typeArray, typeMap, weightArray } from '@/const/map';
import { MenuEntity } from '@/model/menu';
import { getApplicationTree } from '@/services/z-admin/applicationService';
import {
  ModalForm,
  ProForm,
  ProFormCheckbox,
  ProFormDigit,
  ProFormInstance,
  ProFormRadio,
  ProFormSelect,
  ProFormSwitch,
  ProFormText,
  ProFormTreeSelect,
} from '@ant-design/pro-components';
import { Divider, Form } from 'antd';
import { useEffect, useMemo, useRef, useState } from 'react';
import { cloneDeep, merge } from 'lodash';
import { ApplicationEntity } from '@/model/application';
import { addMenu, convertMenuTreeSelect, editMenu } from '@/services/z-admin/menuService';

export type EditModalProps = {
  title?: string;
  values: Partial<MenuEntity>;
  visiable: boolean;
  onFinish?: Function;
  onCancel?: (visible: boolean) => void;
  action?: string;
  extras: Partial<{
    application: string;
  }>;
};

const MenuEditModal: React.FC<EditModalProps> = (props) => {
  const editFormRef = useRef<ProFormInstance>();
  if (props.action == 'add') {
    editFormRef.current?.setFieldsValue(props.values);
  } else if (props.action == 'edit') {
    editFormRef.current?.setFieldsValue(props.values);
  }
  // const [mergeProps setmMergeProps]

  // const mergeProps = useMemo(() => {
  //   return { ...props };
  // }, [props]);

  // useEffect(() => {
  //   setMergeProps(props);
  //   editFormRef.current?.setFieldsValue(props.values);
  //   console.log('merge 改变了' + JSON.stringify(props.values));
  // }, [props]);

  // useEffect(() => {
  // }, [mergeProps]);

  const handleFormValueTransform = (data: EditModalProps, changeValues: any) => {
    if (changeValues.type != undefined || changeValues.openType != undefined) {
      if (data.values.type == 0) {
        if (data.values.openType == 0 || data.values.openType == 1) {
          data.values.component = 'PageView';
        } else if (data.values.openType == 2) {
          data.values.component = 'Iframe';
        } else {
          data.values.component = '';
        }
      } else {
        data.values.component = '';
      }
    }
    return data;
  };

  const onValuesChange = (changeValues: any) => {
    // editFormRef?.current?.setFieldsValue(changeValues);

    // if (changeValues.hasOwnProperty('type')) {
    // }
    const mergeData = handleFormValueTransform(
      merge(props, { values: { ...changeValues } }),
      changeValues,
    );
    console.log('改变了：' + mergeData.values);
    editFormRef.current?.setFieldsValue(mergeData.values);
  };

  const onFinish = async (value: any) => {
    if (props.action == 'edit') {
      await editMenu(value);
    } else {
      await addMenu(value);
    }
    console.log('onFinish:' + JSON.stringify(value));
    props.onFinish?.();
  };

  const createDynamicComponentOne = (data: EditModalProps) => {
    console.log('重新渲染了');
    return (
      <Form.Item
        noStyle
        shouldUpdate={(pre: any, next: any, info) => {
          return pre.type != next.type;
        }}
      >
        {(form) => {
          console.log('更新了' + JSON.stringify(form));
          if (data.values.type == 0) {
            return (
              <ProFormText
                width="md"
                name="redirect"
                label="重定向"
                tooltip="最长为 24 位"
                placeholder="请输入重定向名称"
              />
            );
          } else {
            return (
              <ProFormTreeSelect
                label="父级菜单"
                name="pid"
                width="md"
                allowClear
                request={async () => {
                  return await convertMenuTreeSelect({
                    application: props.extras.application,
                  });
                }}
                fieldProps={{
                  // autoClearSearchValue: true,
                  treeDefaultExpandAll: false,
                }}
              />
            );
          }
        }}
      </Form.Item>
    );
  };

  return (
    <ModalForm
      width="md"
      initialValues={props.values}
      visible={props.visiable}
      title={props.title}
      formRef={editFormRef}
      onVisibleChange={props?.onCancel}
      onFinish={onFinish}
      onValuesChange={onValuesChange}
    >
      <Divider orientation="left">菜单信息</Divider>
      <ProFormText width="md" name="id" label="账户" placeholder="请输入账户" hidden />
      <ProForm.Group>
        <ProFormText
          width="md"
          name="name"
          label="菜单名称"
          tooltip="最长为 24 位"
          placeholder="请输入菜单名称"
          rules={[{ required: true, message: '菜单名称为必填' }]}
        />

        <ProFormText
          width="md"
          name="code"
          label="菜单编号"
          tooltip="最长为 24 位"
          placeholder="请输入菜单编号"
          rules={[{ required: true, message: '菜单编号为必填' }]}
        />
      </ProForm.Group>

      <ProForm.Group>
        <ProFormSelect
          width="md"
          name="application"
          label="所属应用"
          placeholder="请选择所属应用"
          request={async () => {
            return await (
              await getApplicationTree()
            ).data.map((src) => {
              src.label = src.name;
              src.value = src.code;
              return src;
            });
          }}
          disabled={props.action == 'edit' ? true : false}
        />

        <ProFormRadio.Group
          width="md"
          label="菜单层级"
          name="type"
          options={typeArray}
          fieldProps={{
            onChange: (e) => {
              if (e.target.value == 0) {
                // setValue({ component });
              } else {
              }

              // setMergeProps((preState) => {
              //   if (e.target.value == 0) {
              //     if (preState.values.openType == 0) {
              //       preState.values.component = 'PageView';
              //     } else if (preState.values.openType == 1) {
              //       preState.values.component = 'PageView';
              //     } else if (preState.values.openType == 2) {
              //       preState.values.component = 'Iframe';
              //     } else if (preState.values.openType == 3) {
              //       preState.values.component = '';
              //     }
              //   } else if (e.target.value == 1) {
              //     preState.values.component = '';
              //   }

              //   return preState;
              // });
            },
          }}
        />
      </ProForm.Group>

      <ProForm.Group>
        {createDynamicComponentOne(props)}
        <ProFormRadio.Group
          width="md"
          label="打开方式:"
          name="openType"
          options={openTypeArray}
          fieldProps={{}}
        />
      </ProForm.Group>
      <Divider orientation="left">额外</Divider>
      <ProForm.Group>
        <ProFormText
          width="md"
          name="component"
          label="前端地址"
          tooltip="最长为 24 位"
          placeholder="请输入前端地址"
        />

        {props.values.type != 2 ? (
          <ProFormText
            width="md"
            name="router"
            label="路由地址"
            tooltip="最长为 24 位"
            placeholder="请输入路由地址"
          />
        ) : (
          <ProFormText
            width="md"
            name="permission"
            label="权限"
            tooltip="最长为 24 位"
            placeholder="请输入路由地址"
          />
        )}
      </ProForm.Group>
      {props.values.type != 2 ? (
        <ProForm.Group>
          <ProFormText
            width="md"
            name="link"
            label="内外链地址"
            tooltip="最长为 24 位"
            placeholder="请输入内外链地址"
          />
          <ProFormText
            width="md"
            name="icon"
            label="图标"
            tooltip="最长为 24 位"
            placeholder="请输入图标"
          />
        </ProForm.Group>
      ) : (
        <></>
      )}

      <ProForm.Group>
        <ProFormRadio.Group width="md" label="权重:" name="weight" options={weightArray} />
        <ProFormSwitch width="md" label="是否可见" name="visible" />
      </ProForm.Group>
      <ProForm.Group>
        <ProFormDigit width="md" label="排序" name="sort" placeholder="请输入排序" />
        <ProFormText
          width="md"
          name="remark"
          label="备注"
          tooltip="最长为 24 位"
          placeholder="请输入备注"
        />
      </ProForm.Group>
    </ModalForm>
  );
};

export default MenuEditModal;

MenuEditModal.defaultProps = {
  title: '编辑',
};

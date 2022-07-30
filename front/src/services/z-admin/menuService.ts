// @ts-ignore
/* eslint-disable */
import {
  applicationListUrl,
  baseUrl,
  menuAddUrl,
  menuDelelteUrl,
  menuEditUrl,
  menuListUrl,
} from '@/const/base';
import { MenuEntity } from '@/model/menu';
import { request } from 'umi';

function recursion(item) {
  if (item.length > 0) {
    item.forEach((a, _) => {
      a.key = a.id;
      a.value = a.id;
      a.title = a.name;
      recursion(a.children);
    });
  }
}

export async function deleteMenu(input: any) {
  await request(baseUrl + menuDelelteUrl, {
    method: 'POST',
    data: input,
  });
}

export async function convertMenuTreeSelect(data: any) {
  const ret = await request<myAPI.BaseOutPut<MenuEntity[]>>(baseUrl + menuListUrl, {
    method: 'GET',
    params: {
      ...data,
    },
  });
  ret.data.forEach((src) => {
    src.key = src.id;
    src.value = src.id;
    src.title = src.name;
    recursion(src.children);
  });
  console.log('convertData:' + JSON.stringify(ret.data));
  var ParentNode = [{ key: 0, value: 0, title: '顶级', children: ret.data }];

  return ParentNode;
}

export async function addMenu(data: any) {
  try {
    const ret = await request<myAPI.BaseOutPut<any>>(baseUrl + menuAddUrl, {
      method: 'POST',
      data: data,
    });
    return Promise.resolve({
      code: ret.code,
      success: ret.success,
      message: ret.message,
    });
  } catch (e) {
    console.log('更新接口：' + JSON.stringify(e));
  }
}

export async function editMenu(data: any) {
  try {
    const ret = await request<myAPI.BaseOutPut<any>>(baseUrl + menuEditUrl, {
      method: 'POST',
      data: data,
    });
    return Promise.resolve({
      code: ret.code,
      success: ret.success,
      message: ret.message,
    });
  } catch (e) {
    console.log('更新接口：' + JSON.stringify(e));
  }
}

export async function menuListPage(
  params: {
    // query
    /** 当前的页码 */
    current?: number;
    /** 页面的容量 */
    pageSize?: number;
  },
  sort: any,
  filter: any,
) {
  const ret = await request<myAPI.BaseOutPut<MenuEntity[]>>(baseUrl + menuListUrl, {
    method: 'GET',
    params: {
      pageNo: params.current,
      pageSize: params.pageSize,
      ...params,
    },
    ...(filter || {}),
  });

  ret.data.forEach((src) => {
    src.key = src.id;
    recursion(src.children);
  });

  console.log('menu:' + JSON.stringify(ret.data));
  return Promise.resolve({
    data: ret.data,
    success: ret.success,
  }) as any;
}

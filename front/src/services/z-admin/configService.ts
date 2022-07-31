import { baseUrl, configAddUrl, configDeleteUrl, configEditUrl, configPageUrl } from '@/const/base';
import { ConfigEntity } from '@/model/config';
import { request } from 'umi';

export async function systemPage(
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
  const ret = await request<myAPI.BaseOutPut<ConfigEntity>>(baseUrl + configPageUrl, {
    method: 'GET',
    params: {
      pageNo: params.current,
      pageSize: params.pageSize,
      ...params,
    },
    ...(filter || {}),
  });
  return ret;
}

export async function addConfig(data: any) {
  try {
    const ret = await request<myAPI.BaseOutPut<any>>(baseUrl + configAddUrl, {
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

export async function editConfig(data: any) {
  try {
    const ret = await request<myAPI.BaseOutPut<any>>(baseUrl + configEditUrl, {
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

export async function deleteConfig(input: any) {
  await request(baseUrl + configDeleteUrl, {
    method: 'POST',
    data: input,
  });
}

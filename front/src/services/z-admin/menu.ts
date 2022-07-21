// @ts-ignore
/* eslint-disable */
import { applicationListUrl, baseUrl, menuListUrl } from '@/const/base';
import { MenuEntity } from '@/model/menu';
import { request } from 'umi';

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
    
  const ret = await request<myAPI.BaseOutPut<MenuEntity>>(baseUrl + menuListUrl, {
    method: 'GET',
    params: {
      pageNo: params.current,
      pageSize: params.pageSize,
      ...params,
    },
    ...(filter || {}),
  });
  return Promise.resolve({
    data: ret.data,
    success: ret.success,
  }) as any;
}

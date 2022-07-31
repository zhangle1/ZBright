import { baseUrl, dictDataListUrl } from '@/const/base';
import { DictData } from '@/model/dictData';
import { request } from 'umi';

export async function getDictDataList(params: any) {
  const ret = await request<myAPI.BaseOutPut<DictData[]>>(baseUrl + dictDataListUrl, {
    method: 'GET',
    params: {
      ...params,
    },
  });

  return ret;
}

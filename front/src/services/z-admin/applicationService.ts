// @ts-ignore
/* eslint-disable */
import { applicationListUrl, baseUrl } from '@/const/base';
import { request } from 'umi';

export async function getApplicationTree() {
  return request<myAPI.ApplicationTreeResponse>(baseUrl + applicationListUrl, {
    method: 'GET',
    headers: {
      'Content-Type': 'application/json',
    },
    data: {},
  });
}

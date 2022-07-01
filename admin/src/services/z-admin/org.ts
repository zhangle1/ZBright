// @ts-ignore
/* eslint-disable */
import { baseUrl } from '@/const/base';
import { request } from 'umi';


export async function getOrgTree() {
    return request<myAPI.OrgTreeResponse>(baseUrl+'sysOrg/tree', {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        },
        data:{}
    })
}
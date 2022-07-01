// @ts-ignore
/* eslint-disable */
import { baseUrl } from '@/const/base';
import { request } from 'umi';


export async function myLogin(data :myAPI.LoginInput) {
    return request<myAPI.LoginOutPut>(baseUrl+'login', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        data: data,
    })
}
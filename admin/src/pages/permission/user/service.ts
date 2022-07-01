import { baseUrl } from '@/const/base';
import type { UserEntity } from '@/model/user';
import { request } from 'umi';

export async function userPage(
    params: {
        // query
        /** 当前的页码 */
        current?: number;
        /** 页面的容量 */
        pageSize?: number;
    },
    sort: any,
    filter: any
) {

    console.log("params:+" + JSON.stringify( {
        pageNo: params.current,
        pageSize: params.pageSize,
        ...params
    }));




    const ret = await request<myAPI.BaseOutPut<myAPI.BackPageDataOut<UserEntity>>>(baseUrl + "sysUser/page", {
        method: 'GET',
        params: {
            pageNo: params.current,
            pageSize: params.pageSize,
            ...params
        },
        ...(filter || {}),
    });
    console.log("用户列表" + JSON.stringify(ret.data.rows))
    return Promise.resolve({
        data: ret.data.rows,
        success: ret.success,
        total: ret.data.totalRows
    }) as any;
}

export async function userEdit(
    data: any,
) {
    try {
        const ret = await request<myAPI.BaseOutPut<any>>(baseUrl + "sysUser/edit", {
            method: 'POST',
            data: data,
        })
        return Promise.resolve({
            code: ret.code,
            success: ret.success,
            message: ret.message
        })
    } catch (e) {
        console.log("更新接口：" + JSON.stringify(e))
    }

}

export async function userAdd(data: any,){
    try {
        const ret = await request<myAPI.BaseOutPut<any>>(baseUrl + "sysUser/add", {
            method: 'POST',
            data: data,
        })

        return Promise.resolve({
            code: ret.code,
            success: ret.success,
            message: ret.message
        })
    } catch (e) {
        console.log("更新接口：" + JSON.stringify(e))
    }

}

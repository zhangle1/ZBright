import { baseUrl } from '@/const/base';
import type { ApplicationEntity } from '@/model/application';
import { request } from 'umi';

export async function applicationPage(
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
    const ret = await request<myAPI.BaseOutPut<myAPI.BackPageDataOut<ApplicationEntity>>>(baseUrl + "sysApp/page", {
        method: 'GET',
        params: {
            pageNo: params.current,
            pageSize: params.pageSize,
            ...params
        },
        ...(filter || {}),
    });
    console.log("应用列表" + JSON.stringify(ret.data.rows))
    return Promise.resolve({
        data: ret.data.rows,
        success: ret.success,
        total: ret.data.totalRows
    }) as any;
}

 export async function setAsDefault(input: any){
    await request(baseUrl+'sysApp/setAsDefault',{
        method:'POST',
        data:input
    })
 }

 export async function deleteApplication(
    input: any
 ){
    await request(baseUrl+'sysApp/delete',{
        method:'POST',
        data:input
    })
 }


export async function applicationEdit(
    data: any,
) {
    try {
        const ret = await request<myAPI.BaseOutPut<any>>(baseUrl + "sysApp/edit", {
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

export async function applicationAdd(data: any,){
    try {
        const ret = await request<myAPI.BaseOutPut<any>>(baseUrl + "sysApp/add", {
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


import { request } from 'umi';
import { baseUrl } from '@/const/base';
import { Positions } from '@/model/posistion';



export async function positionsList(){


    return request<myAPI.BaseOutPut<Positions[]>>(
        baseUrl+'sysPos/list'
    )


}

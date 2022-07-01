
import type { SysEmpInfo } from '@/model/emp';

export type UserEntity = {
    id: number;
    account: string;
    nickName: string;
    name: string;
    avatar: string;
    birthday: string;
    sex: number;
    email: string;
    phone: string;
    tel: string;
    status: number;
    sysEmpInfo: SysEmpInfo;

}
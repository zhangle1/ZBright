export  type SysEmpInfo = {
    jobNum?: string;
    orgId?: string;
    orgName?: string;
    positions: Positions[]
    extOrgPos: ExtOrgPos[]
}


export type ExtOrgPos = {
    orgId?: number;
    orgCode?: string;
    orgName?: string;
    posId?: number;
    posCode?: string;
    posName?: string;
    id: number;

}


export type Positions = {
    posId: number;
    posCode: string;
    posName: string;
}


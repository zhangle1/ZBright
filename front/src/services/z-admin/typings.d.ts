declare namespace myAPI {
    type LoginInput = {
        account: string;
        password: string;
    }


    export type BaseOutPut<T> = {
        success: string;
        code: number;
        message: string;
        data: T;
        timestamp: number;
    }



    type LoginOutPut = BaseOutPut<string>

    export type BackPageDataOut<Item> = {
        pageNo: number;
        pageSize: number;
        totalPage: number;
        totalRows: number;
        rows: Item[]
    }


    export type OrgTreeEntity = {
        id: number;
        parentId: number;
        title: string;
        value: number;
        weight: number;
        children: OrgTreeEntity[]
    }

    export type OrgTreeView = {
        id: number;
        parentId: number;
        pid: number;
        title: string;
        value: string|number;
        weight: number;
        children: OrgTreeView[]
        key: string|number
    }

    // "name":"测试一下",
    // "code":"1234116161",
    // "active":"N",
    // "status":0,
    // "sort":0,
    // "id":304072398520389,
    // "createdTime":"2022-06-28 15:33:47",
    // "updatedTime":null,
    // "createdUserId":142307070910551,
    // "createdUserName":"superAdmin",
    // "updatedUserId":null,
    // "updatedUserName":null,
    // "isDeleted":false
    export type ApplicationTreeEntity={
        name: string,
        code: string,
        id: number
    }



    export type AntDTreeView={
            title: string;
            value: string;
            

    }


    export type AntDPageOut<T> = {
        total?: number;
        success?: boolean;
        data: T[]
    }

    export type OrgTreeResponse = BaseOutPut<OrgTreeEntity[]>
    export type OrgTreeFormatResponse = BaseOutPut<OrgTreeView[]>



    export type ApplicationTreeResponse=BaseOutPut<ApplicationTreeEntity[]>
}
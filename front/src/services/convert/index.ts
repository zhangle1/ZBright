import { cloneDeep } from "lodash";
import { positionsList } from "../position";
import { getOrgTree } from "../z-admin/org";

function recursionChild(item: myAPI.OrgTreeView[]) {
    if (item.length > 0) {
        item.forEach((a, _) => {
            a.key = a.id;
            recursionChild(a.children)
        })
    }
}

export async function convertOrgToTreeSelect() {
    const data = await getOrgTree() as any
    const target = cloneDeep(data) as myAPI.OrgTreeFormatResponse
    recursionChild(target.data)
    console.log("tree:"+JSON.stringify(target.data))
    return target.data
}

export async function convertPositionToSelect(){
    const data = await positionsList() as any
    const arr = [] as any
    data.data.forEach((item: any) => {
        item.value = item.id;
        item.label = item.name;
        arr.push({ value: item.id, label: item.name })
    })
    return arr
}

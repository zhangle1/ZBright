export const SexMap = {
  1: { text: '男' },
  2: { text: '女' },
  3: { text: '未知性别' },
};

export const typeMap = {
  0: { text: '目录' },
  1: { text: '菜单' },
  2: { text: '按钮' },
};

export const commonMap = {
  0: { text: '正常', status: 'Success' },
  1: { text: '停用', status: 'Default' },
  2: { text: '删除', status: 'Error' },
};

export const DefaultMap = {
  Y: { text: '是' },
  N: { text: '否' },
};

export const typeArray = [
  {
    label: '目录',
    value: 0,
  },
  {
    label: '菜单',
    value: 1,
  },
  {
    label: '按钮',
    value: 2,
  },
];

export const openTypeArray =[
  {
    label:'无',
    value:0,
  },
  {
    label:'组件',
    value:1,
  },
  {
    label:'内链',
    value:2,
  },
  {
    label:'外链',
    value:3,
  }
]

export const weightArray =[
  {
    label:'系统权重',
    value:1,
  },
  {
    label:'业务权重',
    value:2,
  },
]


export type ArrayType = {
  text?: any;
  status?: any;
};

export const convertMapToArray = function (obj: Record<any, ArrayType>) {
  // eslint-disable-next-line @typescript-eslint/no-shadow
  const typeArray = [] as ArrayType[];


  Object.keys(obj).forEach((key) => {
    typeArray.push({
      label: obj[key].text,
      value: key,
    });
  });

  return typeArray;
};

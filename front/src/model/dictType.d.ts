import type { DictData } from './dictData.d';

export type DictType = {
  name: string;
  code: string;
  sort: number;
  remark: string;
  status: number;
  sysDictDatas: DictData[];
  id: number;
  createdTime: string;
  updatedTime: string;
  createdUserId: number;
  createdUserName: string;
  updatedUserId: number;
  updatedUserName: string;
  isDeleted: number;
};

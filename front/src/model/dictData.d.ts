import type { DictType } from './dictType.d';
export type DictData = {
  typeId: number;
  value: string;
  code: string;
  sort: number;
  remark: string;
  status: number;
  sysDictType: DictType;
  id: number;
  createdTime: string;
  updatedTime: string;
  createdUserId: number;
  createdUserName: string;
  updatedUserId: number;
  updatedUserName: string;
  isDeleted: boolean;
};

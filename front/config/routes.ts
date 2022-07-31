export default [
  {
    path: '/user',
    layout: false,
    routes: [
      {
        name: 'login',
        path: '/user/login',
        component: './user/Login',
      },
      {
        component: './404',
      },
    ],
  },
  {
    path: '/permission',
    icon: 'table',
    name: '权限',
    routes: [
      {
        name: '用户权限',
        path: '/permission/user',
        component: './permission/user',
      },
    ],
  },
  {
    path: '/platform',
    icon: 'table',
    name: '平台管理',
    routes: [
      {
        name: '应用管理',
        path: '/platform/application',
        component: './platform/application',
      },
      {
        name: '菜单管理',
        path: '/platform/menu',
        component: './platform/menu',
      },
    ],
  },
  {
    path: '/develop',
    icon: 'table',
    name: '开发管理',
    routes: [
      {
        name: '系统配置',
        path: '/develop/config',
        component: './develop/config',
      },
    ],
  },
  {
    path: '/welcome',
    name: 'welcome',
    icon: 'smile',
    component: './Welcome',
  },
  {
    path: '/admin',
    name: 'admin',
    icon: 'crown',
    access: 'canAdmin',
    routes: [
      {
        path: '/admin/sub-page',
        name: 'sub-page',
        icon: 'smile',
        component: './Welcome',
      },
      {
        component: './404',
      },
    ],
  },
  {
    name: 'list.table-list',
    icon: 'table',
    path: '/list',
    component: './TableList',
  },
  {
    path: '/',
    redirect: '/welcome',
  },
  {
    component: './404',
  },
];

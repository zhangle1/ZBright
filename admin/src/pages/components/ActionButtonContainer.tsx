import { Button, Dropdown, Menu, } from 'antd';

export type ActionButtonContainerProps = {
    scheme: ActionButonEntity[]
}

export type ActionButonEntity = {
    name: string
    children?: ActionButonEntity[],
    type: string
    onClick?: React.MouseEventHandler<HTMLElement>;
}

const ActionButtonContainer: React.FC<ActionButtonContainerProps> = (props) => {
    const { scheme } = props
    const reactNodeList = [] as any

    scheme.forEach((item, _) => {
        let node = null
        let menuNode = null as any
        switch (item.type) {
            case 'button':
                node = (<Button onClick={item.onClick}>{item.name}</Button>)
                break;
            case 'dropdown':
                menuNode = <Menu >
                    {item.children?.map((menu: any, index) => {
                        // eslint-disable-next-line react/no-array-index-key
                        return (<Menu.Item key={index} onClick={menu.onClick}>{menu.name}</Menu.Item>)
                    })}
                </Menu>
                node = (<Dropdown trigger={['click']} overlay={menuNode} placement='bottomLeft'>
                    <Button>{item.name}</Button>
                </Dropdown>)
                break;
            default:
                break;
        }

        reactNodeList.push(node)
    })


    return (reactNodeList)
}


export default ActionButtonContainer;
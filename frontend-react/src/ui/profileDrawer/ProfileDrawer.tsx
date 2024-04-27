// @ts-ignore
import React from 'react';
import {Box, Drawer, ListItem, ListItemButton, ListItemText} from "@mui/material";
import Divider from "@mui/material/Divider";


interface Props {
    open: boolean,
    setOpen: (open: boolean) => void,
    toggleDrawer: (open: boolean) => any,
}

const ProfileDrawer = (props: Props) => {
    const DrawerList = (
        <Box sx={{ width: 250 }} role="presentation" onClick={props.toggleDrawer(false)}>
            <ListItem key={'Войти'} disablePadding>
                <ListItemButton>
                    <ListItemText primary={'Войти'} />
                </ListItemButton>
            </ListItem>
            <Divider />
            <ListItem key={'Панель управления'} disablePadding>
                <ListItemButton>
                    <ListItemText primary={'Панель управления'} />
                </ListItemButton>
            </ListItem>
            <ListItem key={'Войти'} disablePadding>
                <ListItemButton>
                    <ListItemText primary={'Выйти'} />
                </ListItemButton>
            </ListItem>
        </Box>
    );

    return (
        <Drawer anchor={'right'} open={props.open} onClose={props.toggleDrawer(false)}>
            {DrawerList}
        </Drawer>
    );
};

export default ProfileDrawer;
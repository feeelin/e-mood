// @ts-ignore
import React from 'react';
import {Box, Drawer, ListItem, ListItemButton, ListItemText} from "@mui/material";
import Divider from "@mui/material/Divider";
import {useKeycloak} from "@react-keycloak/web";


interface Props {
    open: boolean,
    setOpen: (open: boolean) => void,
    toggleDrawer: (open: boolean) => any,
    authAction: () => void
}

const ProfileDrawer = (props: Props) => {

    const { keycloak, initialized } = useKeycloak();

    return (
        <Drawer anchor={'right'} open={props.open} onClose={props.toggleDrawer(false)}>
            <Box sx={{ width: 250 }} role="presentation" onClick={props.toggleDrawer(false)}>
                {
                    keycloak.authenticated ?
                        <div>
                            <ListItem disablePadding>
                                <ListItemButton>
                                    <ListItemText primary={'Управление плейлистами'} />
                                </ListItemButton>
                            </ListItem>
                            <ListItem disablePadding>
                                <ListItemButton>
                                    <ListItemText primary={'Выйти'} />
                                </ListItemButton>
                            </ListItem>
                        </div>
                        :
                        <ListItem disablePadding>
                            <ListItemButton onClick={(event) => {
                                props.authAction()
                                console.log(event)
                            }}>
                                <ListItemText primary={'Войти'} />
                            </ListItemButton>
                        </ListItem>
                }
                <Divider />
            </Box>
        </Drawer>
    );
};

export default ProfileDrawer;
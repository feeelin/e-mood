// @ts-ignore
import React, {useEffect, useState} from "react";
import ProfileIconButton from "../../ui/profileIconButton/ProfileIconButton.tsx";
import ProfileDrawer from "../../ui/profileDrawer/ProfileDrawer.tsx";
import { useKeycloak } from '@react-keycloak/web';



const ProfileMenuWIthActions = () => {
    const [open, setOpen] = useState(false);

    // @ts-ignore
    const { keycloak, initialized } = useKeycloak();

    useEffect(() => {
        console.log(keycloak.userInfo)
    }, [keycloak.authenticated]);


    const toLogin = () => {
        void keycloak.login();
    };

    const toggleDrawer = (newOpen: boolean) => () => {
        setOpen(newOpen);
    };


    return (
        <div>
            <ProfileIconButton open={toggleDrawer(true)}></ProfileIconButton>
            <ProfileDrawer authAction={toLogin} open={open} setOpen={setOpen} toggleDrawer={toggleDrawer}/>
        </div>
    );
};

export default ProfileMenuWIthActions;
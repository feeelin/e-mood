// @ts-ignore
import React, {useState} from "react";
import ProfileIconButton from "../../ui/profileIconButton/ProfileIconButton.tsx";
import ProfileDrawer from "../../ui/profileDrawer/ProfileDrawer.tsx";



const ProfileMenuWIthActions = () => {
    const [open, setOpen] = useState(false);

    const toggleDrawer = (newOpen: boolean) => () => {
        setOpen(newOpen);
    };


    return (
        <div>
            <ProfileIconButton open={toggleDrawer(true)}></ProfileIconButton>
            <ProfileDrawer open={open} setOpen={setOpen} toggleDrawer={toggleDrawer}/>
        </div>
    );
};

export default ProfileMenuWIthActions;
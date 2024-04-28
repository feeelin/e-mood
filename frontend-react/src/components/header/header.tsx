import './mood.svg'
import Logo from "../../ui/logo/Logo.tsx";
import classes from './header.module.css'
import ProfileMenuWIthActions from "../../modules/profileMenuWithActions/ProfileMenuWIthActions.tsx";
import PlaylistBrowserMenu from "../../modules/playlistBrowserMenu/PlaylistBrowserMenu.tsx";
import PlaylistsList from "../playlistsList/PlaylistsList.tsx";
import FileUpload from "../FileUpload/FileUpload.tsx";
import React from "react";

const Header = () => {
    return (
        <div className={classes.container}>
            <Logo/>
            <div className={classes.headerButtonsContainer}>
                <PlaylistBrowserMenu content={
                    <div>
                        <PlaylistsList/>
                    </div>

                }/>
                <ProfileMenuWIthActions/>
            </div>
        </div>
    );
};

export default Header;
import './mood.svg'
import Logo from "../../ui/logo/Logo.tsx";
import classes from './header.module.css'
import ProfileMenuWIthActions from "../../modules/profileMenuWithActions/ProfileMenuWIthActions.tsx";
import PlaylistBrowserMenu from "../../modules/playlistBrowserMenu/PlaylistBrowserMenu.tsx";
import playlistBrowserIcon from "../../ui/playlistBrowserIcon/PlaylistBrowserIcon.tsx";

const Header = () => {
    return (
        <div className={classes.container}>
            <Logo/>
            <div className={classes.headerButtonsContainer}>
                <PlaylistBrowserMenu content={playlistBrowserIcon}/>
                <ProfileMenuWIthActions/>
            </div>
        </div>
    );
};

export default Header;
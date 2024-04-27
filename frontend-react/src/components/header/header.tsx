import './mood.svg'
import Logo from "../../ui/logo/Logo.tsx";
import classes from './header.module.css'
import ProfileMenuWIthActions from "../../modules/profileMenuWithActions/ProfileMenuWIthActions.tsx";

const Header = () => {
    return (
        <div className={classes.container}>
            <Logo/>
            <ProfileMenuWIthActions/>
        </div>
    );
};

export default Header;
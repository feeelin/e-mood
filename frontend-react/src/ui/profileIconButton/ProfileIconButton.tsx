import Icon from "@mui/material/Icon";

interface Props{
    open: () => void,
}

const ProfileIconButton = (props: Props) => {
    return (
        <Icon
            fontSize={'large'}
            sx={{color: 'white', cursor: 'pointer'}}
            // @ts-ignore
            onClick={ (event) => props.open()}
        >
            account_circle
        </Icon>
    );
};

export default ProfileIconButton;
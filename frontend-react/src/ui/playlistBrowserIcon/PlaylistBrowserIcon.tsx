// @ts-ignore
import React from 'react';
import Icon from "@mui/material/Icon";

interface Props{
    open: () => void,
}

const PlaylistBrowserIcon = (props: Props) => {
    return (
        <Icon
        fontSize={'large'}
        sx={{color: 'white', cursor: 'pointer'}}
        onClick={(event) => {
            props.open()
            console.log(event)
        }
        }
        >
            explore
        </Icon>
    );
};

export default PlaylistBrowserIcon;
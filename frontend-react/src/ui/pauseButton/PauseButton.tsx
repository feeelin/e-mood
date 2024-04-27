// @ts-ignore
import React from 'react';
import Icon from "@mui/material/Icon";
import Fab from "@mui/material/Fab";

interface Props{
    setIsPlaying: (bool: boolean) => void;
}

const PauseButton = (props: Props) => {
    return (
        <Fab onClick={
            // @ts-ignore
            (event) => props.setIsPlaying(false)
        } aria-label={'play'} sx={{width: '12vh', height: '12vh'}}>
            <Icon fontSize={'large'}>pause</Icon>
        </Fab>
    );
};

export default PauseButton;
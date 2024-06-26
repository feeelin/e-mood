// @ts-ignore
import React from 'react';
import Icon from "@mui/material/Icon";
import Fab from "@mui/material/Fab";

interface Props{
    setIsPlaying: (bool: boolean) => void;
}

const PlayButton = (props: Props) => {
    return (
        <Fab onClick={
            // @ts-ignore
            (event) => props.setIsPlaying(true)
        } aria-label={'play'} sx={{width: '12vh', height: '12vh'}}>
            <Icon fontSize={'large'}>play_arrow</Icon>
        </Fab>
    );
};

export default PlayButton;
// @ts-ignore
import React from 'react';
import Icon from "@mui/material/Icon";
import Fab from "@mui/material/Fab";

const PlayButton = () => {
    return (
        <Fab aria-label={'play'} sx={{width: '12vh', height: '12vh'}}>
            <Icon size={'large'}>play_arrow</Icon>
        </Fab>
    );
};

export default PlayButton;
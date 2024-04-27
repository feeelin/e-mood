// @ts-ignore
import React from 'react';
import Icon from "@mui/material/Icon";
import Fab from "@mui/material/Fab";

const NextButton = () => {
    return (
        <Fab sx={{width: '8vh', height: '8vh'}}>
            <Icon fontSize={'large'}>skip_next</Icon>
        </Fab>
    );
};

export default NextButton;
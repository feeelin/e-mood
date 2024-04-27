import React from 'react';
import Icon from "@mui/material/Icon";
import Fab from "@mui/material/Fab";

const PreviousButton = () => {
    return (
        <Fab sx={{width: '8vh', height: '8vh'}}>
            <Icon size={'large'}>skip_previous</Icon>
        </Fab>
    );
};

export default PreviousButton;
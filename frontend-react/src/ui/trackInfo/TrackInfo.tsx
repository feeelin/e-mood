// @ts-ignore
import React from 'react';
import Typography from "@mui/material/Typography";
import classes from './trackInfo.module.css'

interface Props{
    title: string;
    performer: string;
}

const TrackInfo = (props: Props) => {
    return (
        <div className={classes.container}>
            <Typography variant={'h6'} component={'h6'}>{props.title}</Typography>
            <Typography variant={'body2'} component={'p'}>{props.performer}</Typography>
        </div>
    );
};

export default TrackInfo;
// @ts-ignore
import React from 'react';
import TrackSlider from "../../ui/slider/TrackSlider.tsx";
import classes from './player.module.css'
import TrackInfo from "../../ui/trackInfo/TrackInfo.tsx";

const Player = () => {
    return (
        <div className={classes.container}>
            <TrackSlider/>
            <TrackInfo title={'Something in the way'} performer={'Nirvana'}/>
        </div>
    );
};

export default Player;
// @ts-ignore
import React from 'react';
import TrackSlider from "../../ui/slider/TrackSlider.tsx";
import classes from './player.module.css'
import TrackInfo from "../../ui/trackInfo/TrackInfo.tsx";

interface Props{
    duration: number;
    currentDuration: number;
}

const Player = (props: Props) => {
    return (
        <div className={classes.container}>
            <TrackSlider duration={props.duration} currentDuration={props.currentDuration}/>
            <TrackInfo title={'Something in the way'} performer={'Nirvana'}/>
        </div>
    );
};

export default Player;
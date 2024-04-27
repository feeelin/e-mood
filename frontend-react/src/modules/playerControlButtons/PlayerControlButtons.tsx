// @ts-ignore
import React from 'react';
import classes from './PlayerControlButtons.module.css'
import PlayButton from "../../ui/playButton/PlayButton.tsx";
import NextButton from "../../ui/nextButton/NextButton.tsx";
import PreviousButton from "../../ui/previousButton/PreviousButton.tsx";

const PlayerControlButtons = () => {
    return (
        <div className={classes.container}>
            <PreviousButton/>
            <PlayButton/>
            <NextButton/>
        </div>
    );
};

export default PlayerControlButtons;
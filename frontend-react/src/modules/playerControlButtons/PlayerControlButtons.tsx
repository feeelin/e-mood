// @ts-ignore
import React from 'react';
import classes from './PlayerControlButtons.module.css'
import PlayButton from "../../ui/playButton/PlayButton.tsx";
import NextButton from "../../ui/nextButton/NextButton.tsx";
import PreviousButton from "../../ui/previousButton/PreviousButton.tsx";
import PauseButton from "../../ui/pauseButton/PauseButton.tsx";

interface Props{
    isPlaying: boolean,
    setIsPlaying: (bool: boolean) => void,
}

const PlayerControlButtons = (props: Props) => {
    return (
        <div className={classes.container}>
            <PreviousButton/>
            {
                props.isPlaying
                ? <PauseButton setIsPlaying={props.setIsPlaying} />
                : <PlayButton setIsPlaying={props.setIsPlaying}/>
            }
            <NextButton/>
        </div>
    );
};

export default PlayerControlButtons;
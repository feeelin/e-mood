// @ts-ignore
import React from 'react';
import ModeSelection from "../../modules/modeSelection/ModeSelection.tsx";
import PlayerControlButtons from "../../modules/playerControlButtons/PlayerControlButtons.tsx";
import Typography from "@mui/material/Typography";
import classes from './playerControl.module.css'

interface Props{
    isPlaying: boolean,
    setIsPlaying: (bool: boolean) => void,
}

const PlayerControl = (props: Props) => {
    return (
        <div>
            <Typography className={classes.h} variant={'h4'} component={'h4'}>Какой сегодня муд?</Typography>
            <PlayerControlButtons isPlaying={props.isPlaying} setIsPlaying={props.setIsPlaying} />
            <ModeSelection playlistTitle={'Rock Classic super beautiful'}/>
        </div>
    );
};

export default PlayerControl;
import classes from './modeSelection.module.css'
import {useEffect, useState} from "react";
import PlaylistSelectionButton from "../playlistSelectionButton/PlaylistSelectionButton.tsx";
import NeuroSelectionButton from "../neuroSelectionButton/NeuroSelectionButton.tsx";

interface Props{
    playlistTitle: string,
}

type ButtonDescription = 'Сейчас играет' | 'Выключено'

const ModeSelection = (props: Props) => {

    const [playlistActive, setPlaylistActive] = useState<boolean>(false);
    const [neuroActive, setNeuroActive] = useState<boolean>(false);
    const [playlistDescription, setPlaylistDescription] = useState<ButtonDescription>('Выключено');
    const [neuroDescription, setNeuroDescription] = useState<ButtonDescription>('Выключено');

    useEffect(
        () => {
            if(playlistActive){
                setNeuroActive(false);
                setPlaylistDescription('Сейчас играет')
            }else{
                setPlaylistDescription('Выключено')
            }
        }, [playlistActive]
    )

    useEffect(() => {
        if(neuroActive){
            setPlaylistActive(false);
            setNeuroDescription('Сейчас играет')
        }else{
            setNeuroDescription('Выключено')
        }
    }, [neuroActive]);

    return (
        <div className={classes.container}>
            <div className={classes.button}>
                <PlaylistSelectionButton
                    playlistTitle={props.playlistTitle}
                    playlistDescription={playlistDescription}
                    playlistActive={playlistActive}
                    setActive={setPlaylistActive}
                />
            </div>

            <div className={classes.button}>
                <NeuroSelectionButton
                    neuroSubtitle={neuroDescription}
                    active={neuroActive}
                    setActive={setNeuroActive}
                />
            </div>

        </div>
    );
};

export default ModeSelection;
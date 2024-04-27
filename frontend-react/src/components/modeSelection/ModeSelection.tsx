import IconWithSubtitle from "../../ui/iconWithSubtitle/IconWithSubtitle.tsx";
import classes from './modeSelection.module.css'
import {useEffect, useState} from "react";

interface Props{
    playlist_title: string,
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
            <IconWithSubtitle
                title={props.playlist_title}
                subtitle={playlistDescription}
                icon={'queue_music'}
                active={playlistActive}
                setActive={setPlaylistActive}
            />

            <IconWithSubtitle
                title={'Нейро-режим'}
                subtitle={neuroDescription}
                icon={'smart_toy'}
                active={neuroActive}
                setActive={setNeuroActive}
            />
        </div>
    );
};

export default ModeSelection;
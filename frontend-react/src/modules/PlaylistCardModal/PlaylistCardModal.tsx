import {IPlaylist} from "../../api/api.client.ts";
import Typography from "@mui/material/Typography";
import Avatar from "@mui/material/Avatar";
import Modal from "@mui/material/Modal";
import classes from './playlistCardModal.module.css'
import Button from "@mui/material/Button";

interface Props {
    playlist?: IPlaylist;
    open: boolean;
    close: () => void;
}

export default function PlaylistCardModal(props: Props) {
    return (
        <Modal open={props.open}>
            <div className={classes.container}>
                <div className={classes.closeBtn}>
                    <Button color="secondary" onClick={(event) => props.close()} variant='contained' >Закрыть</Button>
                </div>

                <div className={classes.contentContainer}>
                    <Avatar src={props.playlist?.coverUrl}/>
                    <div className={classes.textContainer}>
                        <Typography variant={'h3'} component={'h3'}>{props.playlist?.name}</Typography>
                        <Typography variant={'body2'} component={'p'}>{props.playlist?.description}</Typography>
                    </div>
                </div>
                <div className={classes.songsList}>

                    <ol >
                        {props.playlist?.tracks?.map((track, index) => <Typography className={classes.song} variant={'body1'} component={'p'}>{index + 1}. {track.title} - {track.artist}</Typography>)}
                    </ol>
                </div>
                <div>
                    <Button variant="contained" color="inherit">Добавить</Button>
                </div>
            </div>
        </Modal>
    );
}
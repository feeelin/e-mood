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
                <div className={classes.contentContainer}>
                    <Avatar src={props.playlist?.coverUrl}/>
                    <div className={classes.textContainer}>
                        <Typography variant={'h3'} component={'h3'}>{props.playlist?.name}</Typography>
                        <Typography variant={'body2'} component={'p'}>{props.playlist?.description}</Typography>
                    </div>
                </div>
                <div>
                    <ol>
                        {props.playlist?.tracks?.map((track, index) => <Typography variant={'body1'} component={'p'}>{index + 1}. {track.title} - {track.artist}</Typography>)}
                    </ol>
                </div>
                <div>
                    <Button variant="contained" color="success">Добавить</Button>
                    <Button onClick={(event) => props.close()} variant='contained' color={'error'}>Закрыть</Button>
                </div>
            </div>
        </Modal>
    );
}
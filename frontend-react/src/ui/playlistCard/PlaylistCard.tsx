import Typography from "@mui/material/Typography";
import {Avatar} from "@mui/material";
import classes from './playlistCard.module.css'
import {IPlaylist} from "../../api/api.client.ts";
import Icon from "@mui/material/Icon";

interface Props{
    card: IPlaylist;
    click : (card: IPlaylist) => void;
}

const PlaylistCard = (props: Props) => {
    return (
        // @ts-ignore
        <div className={classes.container} onClick={(event) => props.click(props.card)}>
            <Avatar alt={props.card?.name} src={props.card?.coverUrl} className={classes.avatar}/>
            <div className={classes.textContainer}>
                <Typography variant={'h3'} component={'h3'}>{props.card.name}</Typography>
                <Typography variant={'body2'} component={'p'}>{props.card.description}</Typography>
            </div>
            <Icon fontSize={'large'} sx={{fill: 'white'}}>play_arrow</Icon>
        </div>
    );
};

export default PlaylistCard;
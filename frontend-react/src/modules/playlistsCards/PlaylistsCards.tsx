import {useEffect, useState} from "react";
import PlaylistCard from "../../ui/playlistCard/PlaylistCard.tsx";
import {IPlaylist} from "../../api/api.client.ts";

interface Props{
    onCardsClick: (card: IPlaylist) => void;
}

const PlaylistsCards = (props: Props) => {

    // @ts-ignore
    const [cardsContent, setCardsContent] = useState<IPlaylist[]>([]);

    useEffect(
        () => {
            fetch('https://mood.eureka-team.ru/api/Playlist/ListPlaylists')
                .then(response => response.json())
                .then(data => setCardsContent(data))
                .catch(err => console.log(err))
        },[]
    )

    return (
        <div>
            {cardsContent.map(
                    card => <PlaylistCard key={card.id} card={card} click={props.onCardsClick}/>
                )
            }
        </div>
    );
};

export default PlaylistsCards;
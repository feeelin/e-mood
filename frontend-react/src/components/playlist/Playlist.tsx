import {useState} from "react";

const Playlist = () => {
    const [songsList, setSongList] = useState(['Bohemian Rhapsody', 'Another One Bites The Dust']);

    return (
        <div>

            {songsList && songsList.map(song => {
                return (
                    <div>
                        <h2>{song}</h2>
                    </div>
                )
            })}
        </div>
    );
};

export default Playlist;
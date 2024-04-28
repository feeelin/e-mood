import {useId} from "react";
const POST_LINK = 'https://mood.eureka-team.ru/api/Files/UploadFile?trackId=3fa85f64-5717-4562-b3fc-2c963f66afa6'


const Upload = () => {
    const id = useId()

    const postSong = () => {
        fetch (POST_LINK, {
            method: 'POST',
        })
            .then(r => r.json())
            .then(json => console.log(json))
            .catch(e => console.log(e))
    }

    return (
        <form id={'uploadForm'} onSubmit={()=> postSong()}>
            <label htmlFor={id}>
                <input type="file" id={id} name={'uploadForm'}/>
            </label>
        </form>

    )
}

export default Upload


import Slider from '@mui/material/Slider'
import {Box} from "@mui/material";
import classes from './TrackSlider.module.css'

interface Props{
    duration: number;
}


const TrackSlider = (props: Props) => {

    const maxValue = Math.floor(props.duration/1000)
    const marks = [
        {
            value: 0,
            label: '0:00',
        },
        {
            value: Math.floor(props.duration/1000),
            label: `${Math.floor(props.duration / 60000)}:${Math.floor(props.duration % 60)}`,
        }
    ]

    console.log(marks)

    return (
        <div className={classes.container}>
            <Box  sx={{ width: '90%' }}>
                {/*@ts-ignore*/}
                <Slider
                    sx={{
                        '& .MuiSlider-thumb': {
                            borderRadius: '1px',
                            width: '0px',
                        },
                    }}
                    value={props.currentDuration} max={maxValue} marks={marks} color={'secondary'} fullWidth {...props}></Slider>
            </Box>
        </div>
    );
};

export default TrackSlider;
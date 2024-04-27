# syntax=docker/dockerfile:1.4
FROM pytorch/pytorch:2.3.0-cuda12.1-cudnn8-runtime AS builder

WORKDIR /app


COPY requirements.txt /app
RUN --mount=type=cache,target=/root/.cache/pip \
    pip3 install -r requirements.txt

COPY . /app

EXPOSE 80

ENTRYPOINT ["python3"]
CMD ["app.py"]
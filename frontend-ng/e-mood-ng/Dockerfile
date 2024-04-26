FROM node:18-alpine AS build
WORKDIR /source/app
RUN npm cache clean --force
COPY package.json package-lock.json ./
RUN npm ci
COPY . .
RUN npm run build

FROM nginx:1.22.0-alpine AS nginx
COPY --from=build /source/app/dist/e-mood-ng/browser /usr/share/nginx/html
COPY /nginx-config.conf  /etc/nginx/conf.d/default.conf
EXPOSE 80

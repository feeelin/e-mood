docker run --rm -it -v ${PWD}:/local countingup/nswag swagger2tsclient /input:local/swagger.json /output:local/api.client.ts /generateClientClasses:false /generateContractsOutput:true /template:fetch /className:GeneratedApiClient /configurationClass:ClientConfiguration /useTransformOptionsMethod:true /markOptionalProperties:true



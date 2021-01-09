# The same image used by mybinder.org
FROM python:3.7-slim-buster

# install the notebook package
# force pyzmq==19.0.2 due to incompatibility of IQ# with pyzmq>=20.0.0
RUN pip install --no-cache --upgrade pip && \
    pip install --no-cache notebook pyzmq==19.0.2
--
-- PostgreSQL database dump
--

-- Dumped from database version 17.5 (Debian 17.5-1.pgdg120+1)
-- Dumped by pg_dump version 17.5

-- Started on 2025-08-05 17:54:51

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 220 (class 1259 OID 24622)
-- Name: bookings; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.bookings (
    booking_id integer NOT NULL,
    customer_name character varying(100) NOT NULL,
    performance_id integer NOT NULL,
    vip_seat_ticket integer NOT NULL,
    couple_seat_ticket integer NOT NULL,
    standart_seat_ticket integer NOT NULL,
    created_date timestamp with time zone NOT NULL,
    updated_date timestamp with time zone NOT NULL
);


ALTER TABLE public.bookings OWNER TO postgres;

--
-- TOC entry 219 (class 1259 OID 24621)
-- Name: bookings_booking_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.bookings_booking_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.bookings_booking_id_seq OWNER TO postgres;

--
-- TOC entry 3379 (class 0 OID 0)
-- Dependencies: 219
-- Name: bookings_booking_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.bookings_booking_id_seq OWNED BY public.bookings.booking_id;


--
-- TOC entry 218 (class 1259 OID 24613)
-- Name: performances; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.performances (
    performance_id integer NOT NULL,
    title character varying(100) NOT NULL,
    start_time timestamp without time zone NOT NULL,
    duration_minutes integer NOT NULL,
    amount_vip numeric NOT NULL,
    amount_couple numeric NOT NULL,
    amount_standard numeric NOT NULL,
    created_date timestamp without time zone NOT NULL,
    updated_date timestamp without time zone NOT NULL
);


ALTER TABLE public.performances OWNER TO postgres;

--
-- TOC entry 217 (class 1259 OID 24612)
-- Name: performances_performance_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.performances_performance_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.performances_performance_id_seq OWNER TO postgres;

--
-- TOC entry 3380 (class 0 OID 0)
-- Dependencies: 217
-- Name: performances_performance_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.performances_performance_id_seq OWNED BY public.performances.performance_id;


--
-- TOC entry 221 (class 1259 OID 24633)
-- Name: seat_assignments; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.seat_assignments (
    booking_id integer NOT NULL,
    seat character varying(5) NOT NULL
);


ALTER TABLE public.seat_assignments OWNER TO postgres;

--
-- TOC entry 3220 (class 2604 OID 24625)
-- Name: bookings booking_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bookings ALTER COLUMN booking_id SET DEFAULT nextval('public.bookings_booking_id_seq'::regclass);


--
-- TOC entry 3219 (class 2604 OID 24616)
-- Name: performances performance_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.performances ALTER COLUMN performance_id SET DEFAULT nextval('public.performances_performance_id_seq'::regclass);


--
-- TOC entry 3224 (class 2606 OID 24627)
-- Name: bookings bookings_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bookings
    ADD CONSTRAINT bookings_pkey PRIMARY KEY (booking_id);


--
-- TOC entry 3222 (class 2606 OID 24620)
-- Name: performances performances_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.performances
    ADD CONSTRAINT performances_pkey PRIMARY KEY (performance_id);


--
-- TOC entry 3226 (class 2606 OID 24642)
-- Name: seat_assignments seat_assignments_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.seat_assignments
    ADD CONSTRAINT seat_assignments_pkey PRIMARY KEY (booking_id, seat);


--
-- TOC entry 3227 (class 2606 OID 24628)
-- Name: bookings bookings_performance_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bookings
    ADD CONSTRAINT bookings_performance_id_fkey FOREIGN KEY (performance_id) REFERENCES public.performances(performance_id);


--
-- TOC entry 3228 (class 2606 OID 24636)
-- Name: seat_assignments seat_assignments_booking_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.seat_assignments
    ADD CONSTRAINT seat_assignments_booking_id_fkey FOREIGN KEY (booking_id) REFERENCES public.bookings(booking_id);


-- Completed on 2025-08-05 17:54:51

--
-- PostgreSQL database dump complete
--


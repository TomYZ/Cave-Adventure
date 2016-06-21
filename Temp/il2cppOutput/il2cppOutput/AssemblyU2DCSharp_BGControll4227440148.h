#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject
struct GameObject_t4012695102;
// UnityEngine.Transform
struct Transform_t284553113;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// BGControll
struct  BGControll_t4227440148  : public MonoBehaviour_t3012272455
{
public:
	// System.Single BGControll::mSpeed
	float ___mSpeed_2;
	// UnityEngine.GameObject BGControll::target
	GameObject_t4012695102 * ___target_3;
	// UnityEngine.Transform BGControll::_t
	Transform_t284553113 * ____t_4;
	// System.Single BGControll::threshold
	float ___threshold_5;
	// System.Single BGControll::translate
	float ___translate_6;
	// System.Single BGControll::last_position
	float ___last_position_7;
	// System.Single BGControll::last_frame_position
	float ___last_frame_position_8;

public:
	inline static int32_t get_offset_of_mSpeed_2() { return static_cast<int32_t>(offsetof(BGControll_t4227440148, ___mSpeed_2)); }
	inline float get_mSpeed_2() const { return ___mSpeed_2; }
	inline float* get_address_of_mSpeed_2() { return &___mSpeed_2; }
	inline void set_mSpeed_2(float value)
	{
		___mSpeed_2 = value;
	}

	inline static int32_t get_offset_of_target_3() { return static_cast<int32_t>(offsetof(BGControll_t4227440148, ___target_3)); }
	inline GameObject_t4012695102 * get_target_3() const { return ___target_3; }
	inline GameObject_t4012695102 ** get_address_of_target_3() { return &___target_3; }
	inline void set_target_3(GameObject_t4012695102 * value)
	{
		___target_3 = value;
		Il2CppCodeGenWriteBarrier(&___target_3, value);
	}

	inline static int32_t get_offset_of__t_4() { return static_cast<int32_t>(offsetof(BGControll_t4227440148, ____t_4)); }
	inline Transform_t284553113 * get__t_4() const { return ____t_4; }
	inline Transform_t284553113 ** get_address_of__t_4() { return &____t_4; }
	inline void set__t_4(Transform_t284553113 * value)
	{
		____t_4 = value;
		Il2CppCodeGenWriteBarrier(&____t_4, value);
	}

	inline static int32_t get_offset_of_threshold_5() { return static_cast<int32_t>(offsetof(BGControll_t4227440148, ___threshold_5)); }
	inline float get_threshold_5() const { return ___threshold_5; }
	inline float* get_address_of_threshold_5() { return &___threshold_5; }
	inline void set_threshold_5(float value)
	{
		___threshold_5 = value;
	}

	inline static int32_t get_offset_of_translate_6() { return static_cast<int32_t>(offsetof(BGControll_t4227440148, ___translate_6)); }
	inline float get_translate_6() const { return ___translate_6; }
	inline float* get_address_of_translate_6() { return &___translate_6; }
	inline void set_translate_6(float value)
	{
		___translate_6 = value;
	}

	inline static int32_t get_offset_of_last_position_7() { return static_cast<int32_t>(offsetof(BGControll_t4227440148, ___last_position_7)); }
	inline float get_last_position_7() const { return ___last_position_7; }
	inline float* get_address_of_last_position_7() { return &___last_position_7; }
	inline void set_last_position_7(float value)
	{
		___last_position_7 = value;
	}

	inline static int32_t get_offset_of_last_frame_position_8() { return static_cast<int32_t>(offsetof(BGControll_t4227440148, ___last_frame_position_8)); }
	inline float get_last_frame_position_8() const { return ___last_frame_position_8; }
	inline float* get_address_of_last_frame_position_8() { return &___last_frame_position_8; }
	inline void set_last_frame_position_8(float value)
	{
		___last_frame_position_8 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
